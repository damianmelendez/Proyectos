import json
from PIL import Image
import random
import os

# ---------------- CONFIGURACIÓN DEL PROYECTO ----------------

# 1. El texto que quieres transformar
TEXTO_ENTRADA = "aaaaaa."

# 2. Rutas de los archivos (ajustadas a tu estructura)
# El archivo de mapeo JSON (debe estar en la misma carpeta que generador.py)
ARCHIVO_JSON = "mapa_letras.json"
# La carpeta donde están guardados todos tus archivos .png de letras
RUTA_CARPETA_LETRAS = "imagenes_letras/" 

# 3. Estilo
ESPACIO_ENTRE_LETRAS = 8 # Píxeles de separación horizontal entre letras

# ---------------- FUNCIONES PRINCIPALES ----------------

def generar_texto_escrito(texto):
    print("Iniciando la generación de la imagen...")
    
    # 1. Cargar el Mapeo JSON
    try:
        # Nota importante: Asegúrate de que el JSON no tenga comentarios (//)
        with open(ARCHIVO_JSON, 'r', encoding='utf-8') as f:
            mapa_letras = json.load(f)
        print(f"✔️ Mapeo de letras cargado desde {ARCHIVO_JSON}.")
    except FileNotFoundError:
        print(f"❌ Error: No se encontró el archivo {ARCHIVO_JSON}. Asegúrate de que esté en el directorio correcto.")
        return
    except json.JSONDecodeError as e:
        print(f"❌ Error de formato JSON: El archivo {ARCHIVO_JSON} no es válido. Revisa las comas y asegúrate de eliminar todos los comentarios (//).")
        print(f"Detalle del error: {e}")
        return

    imagenes_a_pegar = []
    ancho_total = 0
    altura_maxima = 0

    # 2. Pre-cargar imágenes, seleccionar al azar y calcular dimensiones
    for caracter in texto:
        if caracter not in mapa_letras:
            print(f"⚠️ Advertencia: El caracter '{caracter}' no está en el mapa JSON. Será omitido.")
            continue
        
        opciones = mapa_letras[caracter]
        
        # Lógica de Selección Aleatoria
        if isinstance(opciones, list):
            # Si es una lista, selecciona una imagen al azar de las opciones
            nombre_archivo = random.choice(opciones)
        else: 
            # Si es una cadena (string), usa esa única imagen (sin aleatoriedad)
            nombre_archivo = opciones
            
        # Construir la ruta completa al archivo de imagen
        ruta_imagen = os.path.join(RUTA_CARPETA_LETRAS, nombre_archivo)
        
        try:
            # Cargar la imagen y asegurar que tenga transparencia (RGBA)
            imagen_letra = Image.open(ruta_imagen).convert("RGBA")
            imagenes_a_pegar.append(imagen_letra)
            
            # Cálculo de dimensiones
            ancho_total += imagen_letra.width + ESPACIO_ENTRE_LETRAS
            if imagen_letra.height > altura_maxima:
                altura_maxima = imagen_letra.height
                
        except FileNotFoundError:
            print(f"❌ Error: No se encontró el archivo de imagen: {ruta_imagen}. Revisa el nombre en el JSON.")
            return

    # Si no hay contenido para pegar, salir
    if not imagenes_a_pegar:
        print("No se encontraron letras válidas para generar la imagen.")
        return

    # Ajustar el ancho total (quitar el último espacio extra)
    ancho_total -= ESPACIO_ENTRE_LETRAS 
    
    # 3. Crear Lienzo (Fondo Transparente)
    # (0, 0, 0, 0) significa R=0, G=0, B=0, A=0 (Alpha/Transparencia = 0)
    lienzo = Image.new('RGBA', (ancho_total, altura_maxima), (0, 0, 0, 0))
    print(f"✔️ Lienzo creado (Ancho: {ancho_total}px, Alto: {altura_maxima}px).")
    
    # 4. Ensamblar la Imagen
    posicion_x = 0
    for imagen in imagenes_a_pegar:
        # Pegar la imagen. El tercer argumento (imagen) actúa como máscara para la transparencia.
        lienzo.paste(imagen, (posicion_x, 0), imagen) 
        posicion_x += imagen.width + ESPACIO_ENTRE_LETRAS # Mover la posición para la siguiente letra

    # 5. Guardar el Resultado
    nombre_salida = "texto_escrito_FINAL.png"
    lienzo.save(nombre_salida, "PNG")
    print(f"\n✅ Imagen generada con éxito y guardada como: {nombre_salida}")

# ---------------- REQUERIMIENTO Y EJECUCIÓN ----------------

# Antes de ejecutar, asegúrate de:
# 1. Haber instalado la biblioteca PIL/Pillow: pip install Pillow
# 2. Haber eliminado todos los comentarios (//) de mapa_letras.json

if __name__ == "__main__":
    generar_texto_escrito(TEXTO_ENTRADA)
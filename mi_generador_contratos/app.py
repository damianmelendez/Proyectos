import os
from flask import Flask, render_template, request, send_file
from weasyprint import HTML, CSS
from io import BytesIO
import re # Para simplificar la limpieza del nombre del archivo

app = Flask(__name__)

# Función auxiliar para convertir el nombre a un nombre de archivo limpio
def clean_filename(name):
    """Limpia el nombre para usarlo en un archivo (ej: quita espacios y caracteres especiales)."""
    name = name.replace(' ', '_').replace('.', '').replace(',', '')
    return re.sub(r'[^\w\-_\.]', '', name)

@app.route('/', methods=['GET', 'POST'])
def index():
    if request.method == 'POST':
        # --- 1. Recibir los datos del formulario ---
        datos = request.form.to_dict()
        
        # --- 2. Renderizar la plantilla HTML con los datos ---
        # El motor Jinja2 de Flask inyecta los datos en contrato_plantilla.html
        rendered_html = render_template('contrato_plantilla.html', **datos)
        
        # --- 3. Generar el PDF usando WeasyPrint ---
        
        # Creamos un objeto BytesIO en memoria para guardar el PDF (más seguro que guardarlo en disco)
        pdf_stream = BytesIO()
        
        # WeasyPrint toma el HTML renderizado y lo convierte a PDF
        HTML(string=rendered_html).write_pdf(pdf_stream)
        pdf_stream.seek(0) # Regresa el puntero al inicio del stream
        
        # Crear un nombre de archivo limpio para la descarga
        nombre_arrendatario = datos.get('NOMBRE_ARRENDATARIO_COMPLETO', 'Contrato')
        anio = datos.get('ANIO_INICIO', '0000')
        nombre_archivo = f"Contrato_{clean_filename(nombre_arrendatario)}_{anio}.pdf"

        # --- 4. Enviar el PDF al navegador para descarga ---
        return send_file(
            pdf_stream,
            download_name=nombre_archivo,
            as_attachment=True,
            mimetype='application/pdf'
        )

    # Si es un método GET, mostrar el formulario de entrada de datos
    return render_template('index.html')

if __name__ == '__main__':
    # Usar un puerto diferente si el 5000 está ocupado
    app.run(debug=True, port=5000)
using NUnit.Framework;
using MODELO;

namespace NUnitTestProject1
{
    public class StubTests
    {

        [Test]
        public void StubsAgregarBlog()
        {
            var blog = new Blog();

            blog.titulo = "Nuevos baños en la biblioteca";
            blog.imagen = "EjemploImagen.jpg";
            blog.descripcion = "Se construyeron baños en la biblioteca en el sector F...";

            //Stubs de Titulo del blog
            Assert.IsFalse(string.IsNullOrEmpty(blog.titulo));
            Assert.IsTrue(blog.titulo is string);
            Assert.IsTrue(blog.titulo.Length > 10 && blog.titulo.Length <= 300);

            //Stubs de la descripción del blog
            Assert.IsFalse(string.IsNullOrEmpty(blog.descripcion));
            Assert.IsTrue(blog.descripcion is string);
            Assert.IsTrue(blog.descripcion.Length > 10 && blog.descripcion.Length <= 2000);

            //Stubs de la imagen del blog
            Assert.IsFalse(string.IsNullOrEmpty(blog.imagen));
            Assert.IsTrue(blog.imagen is string);
            Assert.IsTrue(blog.imagen.EndsWith(".jpg") || blog.imagen.EndsWith(".png"));


        }
    }
}
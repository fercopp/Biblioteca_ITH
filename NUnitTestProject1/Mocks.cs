using NUnit.Framework;
using MODELO;

namespace NUnitTestProject1
{
    public class MockTests
    {
        public int blogAgregados;

        [Test]
        public void MockAgregarBlog()
        {
            var blog01 = new Blog();
            var blog02 = new Blog();

            blog01.titulo = "Nuevos baños en la biblioteca";
            blog01.imagen = "EjemploImagen.jpg";
            blog01.descripcion = "Se construyeron baños en la biblioteca en el sector F...";
            agregarBlog(blog01);

            blog02.titulo = "Nuevas mesas en la biblioteca";
            blog02.imagen = "EjemploImagen2.png";
            blog02.descripcion = "Se compraron mesas en la biblioteca en el sector C...";
            agregarBlog(blog02);



            Assert.AreEqual(blogAgregados, 2);
        }

        public void agregarBlog(Blog blogAgregado)
        {
            blogAgregados = blogAgregados + 1;
        }
    }
}
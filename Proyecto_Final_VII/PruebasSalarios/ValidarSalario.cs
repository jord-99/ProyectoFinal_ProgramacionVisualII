using System;
using Escenarios;
using Procesos;
using Simulacion;
using Xunit;
using Modelo.Empresa;
using Persistencia;

namespace PruebasSalarios
{
    public class ValidarSalario
    {
        public ValidarSalario()
        {
            // Código para crear el escenario 1
            Escenario01 escenario = new Escenario01();
            EscenarioControl control = new EscenarioControl();
            control.Grabar(escenario);
            // Código para crear las matrículas
            var datosSalarios = new DatosSalarios();
            datosSalarios.Generar();
        }

        [Theory]
        [InlineData("Luis Gutierrez", true)]
        [InlineData("Ana Velasquez ", true)]
        [InlineData("Rosa Perez", true)]
        public void VerificarSalarios(string strEmpleado, bool resEsperado)
        {
            //preparacion
            bool resReal;
            //Ejecucion
            resReal = SalarioProc.ConsultaYValidaSalarioPendiente(strEmpleado);
            //validacion
            if (resEsperado)
            {
                Assert.True(resReal);
            }
            else
            {
                Assert.False(resReal);
            }
        }
        //peridodo 2019
        [Theory]
        [InlineData("Luis Gutierrez",535.00, 183.01,730,true)]
        [InlineData("Ana Velasquez ", 500,248.77,1500,true)]
        [InlineData("Rosa Perez", 425,356.16,800,true)]
        public void calculodecimotercersueldo(string strEmpleado, float decimotercer, float decimocuarto, float utilidades, bool resEsperado)
        {
            bool resultado;
            using (var context = new EmpresaContext())
            {
                Salario config = context.salarios.Find(4);
                config.SueldoBasico = 400.00f;
                context.SaveChanges();

                SalarioProc opCalif = new SalarioProc(context);
                resultado = opCalif.Aprobado(strEmpleado, decimotercer,decimocuarto,utilidades);
            }
            if (resEsperado)
                Assert.True(resultado, strEmpleado + " debe estar Aprobado");
            else
                Assert.False(resultado, strEmpleado + " debe estar Reprobado *");
        }
       
    }
}

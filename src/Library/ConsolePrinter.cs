//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System;
namespace Full_GRASP_And_SOLID.Library
{
    /* Aqui creo una clase nueva ConsolePrinter que respeta
    el patron SRP teniendo como unica responsabilidad imprimir el
    cuerpo de la receta, dejando a la clase Recipe la responsabilidad
    de encargarse de la receta en si: sus pasos y costo de producción
    */
    public class ConsolePrinter
    {
        public void Printer(Recipe recipe)
        {
            Console.WriteLine(recipe.RecipeMaker());
        }
           
    }
}
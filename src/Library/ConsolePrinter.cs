//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System;
using System.Text;
namespace Full_GRASP_And_SOLID.Library
{
    /* Aqui creo una clase nueva ConsolePrinter que respeta
    el patron SRP teniendo como unica responsabilidad imprimir el
    cuerpo de la receta, dejando a la clase Recipe la responsabilidad
    de encargarse de la receta en si: sus pasos y costo de producción
    */
    public class ConsolePrinter
    {
        public ConsolePrinter(Recipe recipe)
        {
            StringBuilder stringRecipe = new StringBuilder($"Receta de {recipe.FinalProduct.Description} \n");
            foreach(Step Recipe in recipe.steps)
            {
                stringRecipe.Append($"{Recipe.Quantity} de '{Recipe.Input.Description}', utilizando '{Recipe.Equipment.Description}' durante un lapso de {Recipe.Time} segundos\n");
            }
            Console.WriteLine(stringRecipe.ToString());
        }
           
    }
}
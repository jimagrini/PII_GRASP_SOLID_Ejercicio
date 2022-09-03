//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public double GetProductionCost() 
        {
            double ProductionCost = 0;
            if(this.steps.Count != 0) 
            {
                foreach (Step step in this.steps) 
                {
                    ProductionCost+= (step.Input.UnitCost*step.Quantity)+(step.Time*step.Equipment.HourlyCost);
                }
            } 
            Console.WriteLine($"El costo total es ${ProductionCost}");
            return ProductionCost;
        }
        /*
        Respeta SRP debido a que la unica razón de cambio sería la receta misma
        La clase Recipe es la experta debido a que tiene toda la información necesaria para calcular el costo de produccion total,
        contiene el cuerpo de la receta también pero ya no se encarga de imprimirlo.
        */
        public ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }
        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public string RecipeMaker() 
        {
            StringBuilder stringRecipe = new StringBuilder($"Receta de {FinalProduct.Description} \n");
            foreach (Step step in this.steps)
            {
                stringRecipe.Append($"{step.Quantity} de '{step.Input.Description}', utilizando '{step.Equipment.Description}' durante un lapso de {step.Time} segundos\n");
            }
            return stringRecipe.ToString();
        }
    }



}

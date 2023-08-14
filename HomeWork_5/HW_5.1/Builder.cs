using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    class Builder : IDeveloper
    {
        public string Tool { get; set; }
        public string ConstructionTool { get; set; }

        public Builder(string constructionTool)
        {
            ConstructionTool = constructionTool;
            Tool = "Інструментом";
        }

        public void Create()
        {
            Console.WriteLine($"Будівельник, користується {Tool}, будує за допомогою {ConstructionTool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Будівельник, користується {Tool}, руйнує за допомогою {ConstructionTool}");
        }
    }
}

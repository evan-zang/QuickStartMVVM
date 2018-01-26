using Microsoft.Practices.Prism.Mvvm;
using MVVMQuickstart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMQuickstart.ViewModels
{
    class QuestionnaireViewModel:BindableBase

    {
        public QuestionnaireViewModel()
        {
            this.Questionnaire = new Questionnaire();
            this.AllColors = new[] { "Red", "Blue","Green" };
        }

        private Questionnaire questionnaire;

        public Questionnaire Questionnaire
        {
            get => questionnaire;
            set
            {
                SetProperty(ref this.questionnaire, value);
            }
        }                
        public IEnumerable<string> AllColors { get; private set; }        
    }
}

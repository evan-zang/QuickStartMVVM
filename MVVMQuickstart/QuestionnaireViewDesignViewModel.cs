using MVVMQuickstart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMQuickstart
{
    class QuestionnaireViewDesignViewModel
    {
        public QuestionnaireViewDesignViewModel()
        {
            this.QuestionnaireViewModel = new QuestionnaireViewModel();
        }
        public QuestionnaireViewModel QuestionnaireViewModel { get; set; }
    }
}

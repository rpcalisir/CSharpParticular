using LooseCouplingPrinciple.Concrete;
using LooseCouplingPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCouplingPrinciple
{
    /// <summary>
    /// IScreen arayüzünü implement eden her sınıf, ScreenCreator tarafından kullanılabilir.
    /// Diğer yandan IScreen arayüzünü implemente eden tipler içerisinde yapılacak değişimler, ScreenCreator sınıfını doğrudan etkilemeyecektir.
    /// </summary>
    public class ScreenCreator
    {
        private readonly IScreen _winScreen;
        public ScreenCreator()
        {

        }
        public ScreenCreator(IScreen winScreen)
        {
            _winScreen = winScreen;
        }
        public void InitializeScreen()
        {
            _winScreen.Initialize();
        }
        public void DrawScreen()
        {
            _winScreen.Draw();
        }

    }
}

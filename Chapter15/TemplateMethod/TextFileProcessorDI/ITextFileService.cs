using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise03 {
    internal interface ITextFileService {
        void Initialize(string fileName);
        void Execute(string line);
        void Terminate();
    }
}

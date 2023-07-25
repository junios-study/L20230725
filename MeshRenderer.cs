using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725
{
    class MeshRenderer
    {
        public MeshRenderer() { }
        ~MeshRenderer() { }

        public virtual void Render()
        {
            //Meshfilter에 정보를 가져와서 그걸 그리는
            //나를 GameObject의 정보를 알아야 함
            //나를 소유한 GameObject로부터 MeshFilter를 찾아서 Shape를 가져옴
            //그림
        }
    }
}

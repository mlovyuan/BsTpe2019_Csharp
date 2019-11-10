using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class GetQuestion
    {
        public int Question { get; set; }
        public int A { get; private set; }
        public int B { get; private set; }
        public void CheckAns(string text)
        {
            string QT = Question.ToString();
            A = 0; B = 0;
            for (int i =0; i < text.Length; i++)
            {
                if (text[i] == QT[i])
                {
                    A++;
                }
                else if (QT.Contains(text[i]))
                {
                    B++;
                }
            }
            /* Method2
            //先找兩者交集的數字有誰
            var intersect = QT.Intersect(text);
            A = 0;
            //如果交集數大於零
            if (intersect.Count() > 0)
            {
                //  把索引值相同的計算出來      對照它各個char的索引值是否相同
                A = intersect.Count((x) => text.IndexOf(x) == QT.IndexOf(x));
            }
            B = intersect.Count() - A; */
        }
    }
}

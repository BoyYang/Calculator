using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    public interface ICaculatable
    {
        /// <summary>
        /// 计算方法
        /// </summary>
        /// <returns></returns>
        int GetResult();

        /// <summary>
        /// 运算符
        /// </summary>
        string Opertation
        { get; }
    }
}

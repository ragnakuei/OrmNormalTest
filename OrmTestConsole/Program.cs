using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Running;
using OrmTest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmTestConsole
{
    static class Program
    {
        public static void Main(string[] args)
        {
            //var _dapperDAL = new DapperDAL();
            //Console.WriteLine(_dapperDAL.Get().Count);

            //var _efDAL = new EfDAL();
            //Console.WriteLine(_efDAL.Get().Count);

            BenchmarkRunner.Run<Benchmark>();
            Console.ReadLine();
        }
    }

    [MemoryDiagnoser]
    [InliningDiagnoser]
    [TailCallDiagnoser]
    public class Benchmark
    {
        private readonly TestClass _benchClass = new TestClass();

        [Benchmark]
        public void Dapper() => _benchClass.Dapper();

        [Benchmark]
        public void EF() => _benchClass.EF();

    }
}

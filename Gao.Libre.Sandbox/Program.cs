using Gao.Libre.GameMasterEmulation.Mechanic;
using System;
using System.Linq;
using System.Text;

namespace Gao.Libre.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMissions();
        }

        private static void GenerateMissions()
        {
            var sb = new StringBuilder();
            foreach(var mission in Enumerable.Range(1,100).Select(i => MissionFactory.GenerateMission()))
            {
                sb.AppendLine("Mission - " + mission.ToString());
            }
            var text = sb.ToString();
            Console.WriteLine(text);
        }
    }
}

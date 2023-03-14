using NUnit.Framework;
using bangunruang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangunruangtest
{
    /// <summary>
    /// main class
    /// </summary>
    [TestFixture()]
    public class bangunruangtest // membuat public class untuk memasukan fungsi dan variabel
    {
        BangunRuang RB;
        [SetUp]
        public void init() // fungsi main dimana public pada bagian ini berarti bahwa metode-metode dapat dipanggil didalam dan juga diluar kelas
        {
            RB = new BangunRuang(); // membuat variabel
        }



        [Test()] 
        public void VolKubusTest() // fungsi main dimana public pada bagian ini berarti bahwa metode-metode dapat dipanggil didalam dan juga diluar kelas
        {
            double hasilkubus = RB.VolKubus(5); // menampilkan hasil kubus
            Assert.AreEqual(125, hasilkubus);
        }

        [Test()]
        public void VoltabungTest() // fungsi main dimana public pada bagian ini berarti bahwa metode-metode dapat dipanggil didalam dan juga diluar kelas
        {
            double hasiltabung = RB.VolTabung(3.14, 10, 20); // menampilkan hasil tabung
            Assert.AreEqual(6280, hasiltabung);
        }

        [Test()]
        public void VolbalokTest()
        {
            double hasilbalok = RB.VolBalok(3, 5, 7);
            Assert.AreEqual(105, hasilbalok);
        }
    }
}
﻿using Atacado.Domain.Ancestral;
using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.FakeDB.RH
{
    public static class EmpresaFakeDB
    {
        private static List<Empresa> empresas = new List<Empresa>();

        public static List<Empresa> Empresas
        {
            get
            {
                if (empresas.Count() == 0)
                {
                    AdicionarEmpresas();
                }
                return empresas;
            }
        }
        public static void AdicionarEmpresas()
        {

            empresas.Add(new Empresa(1, "030-0074321", "alfki@acme.com.br", "Obere Str. 57", "Maria Anders", "Alfreds Futterkiste", "36012788000101", "202204011"));
            empresas.Add(new Empresa(2, "(5) 555-4729", "anatr@acme.com.br", "Avda. de la Constitución 2222", "Ana Trujillo", "Ana Trujillo Emparedados y helados", "82210474000122", "202204012"));
            empresas.Add(new Empresa(3, "(5) 555-3932", "anton@acme.com.br", "Mataderos  2312", "Antonio Moreno", "Antonio Moreno Taquería", "77520808000124", "202204013"));
            empresas.Add(new Empresa(4, "(171) 555-7788", "arout@acme.com.br", "120 Hanover Sq.", "Thomas Hardy", "Around the Horn", "60127677000117", "202204014"));
            empresas.Add(new Empresa(5, "0921-12 34 65", "bergs@acme.com.br", "Berguvsvägen  8", "Christina Berglund", "Berglunds snabbköp", "74303518000130", "202204015"));
            empresas.Add(new Empresa(6, "0621-08460", "blaus@acme.com.br", "Forsterstr. 57", "Hanna Moos", "Blauer See Delikatessen", "5152218000185", "202204016"));
            empresas.Add(new Empresa(7, "88.60.15.31", "blonp@acme.com.br", "24, place Kléber", "Frédérique Citeaux", "Blondesddsl père et fils", "45414625000138", "202204017"));
            empresas.Add(new Empresa(8, "(91) 555 22 82", "bolid@acme.com.br", "C/ Araquil, 67", "Martín Sommer", "Bólido Comidas preparadas", "1867221000124", "202204018"));
            empresas.Add(new Empresa(9, "91.24.45.40", "bonap@acme.com.br", "12, rue des Bouchers", "Laurence Lebihan", "Bon app'", "31502318000102", "202204019"));
            empresas.Add(new Empresa(10, "(604) 555-4729", "bottm@acme.com.br", "23 Tsawassen Blvd.", "Elizabeth Lincoln", "Bottom-Dollar Markets", "60121546000122", "202204020"));
            empresas.Add(new Empresa(11, "(171) 555-1212", "bsbev@acme.com.br", "Fauntleroy Circus", "Victoria Ashworth", "B's Beverages", "71226870000121", "202204021"));
            empresas.Add(new Empresa(12, "(1) 135-5555", "cactu@acme.com.br", "Cerrito 333", "Patricio Simpson", "Cactus Comidas para llevar", "83726673000150", "202204022"));
            empresas.Add(new Empresa(13, "(5) 555-3392", "centc@acme.com.br", "Sierras de Granada 9993", "Francisco Chang", "Centro comercial Moctezuma", "33835363000104", "202204023"));
            empresas.Add(new Empresa(14, "0452-076545", "chops@acme.com.br", "Hauptstr. 29", "Yang Wang", "Chop-suey Chinese", "46432145000162", "202204024"));
            empresas.Add(new Empresa(15, "(11) 555-7647", "commi@acme.com.br", "Av. dos Lusíadas, 23", "Pedro Afonso", "Comércio Mineiro", "26573474000116", "202204025"));
            empresas.Add(new Empresa(16, "(171) 555-2282", "consh@acme.com.br", "Berkeley Gardens 12  Brewery", "Elizabeth Brown", "Consolidated Holdings", "48218045000163", "202204026"));
            empresas.Add(new Empresa(17, "0241-039123", "dracd@acme.com.br", "Walserweg 21", "Sven Ottlieb", "Drachenblut Delikatessen", "43601265000158", "202204027"));
            empresas.Add(new Empresa(18, "40.67.88.88", "dumon@acme.com.br", "67, rue des Cinquante Otages", "Janine Labrune", "Du monde entier", "78216304000188", "202204028"));
            empresas.Add(new Empresa(19, "(171) 555-0297", "eastc@acme.com.br", "35 King George", "Ann Devon", "Eastern Connection", "32666303000134", "202204029"));
            empresas.Add(new Empresa(20, "7675-3425", "ernsh@acme.com.br", "Kirchgasse 6", "Roland Mendel", "Ernst Handel", "60438425000109", "202204030"));
            empresas.Add(new Empresa(21, "(11) 555-9857", "famia@acme.com.br", "Rua Orós, 92", "Aria Cruz", "Familia Arquibaldo", "71785441000194", "202204031"));
            empresas.Add(new Empresa(22, "(91) 555 94 44", "fissa@acme.com.br", "C/ Moralzarzal, 86", "Diego Roel", "FISSA Fabrica Inter. Salchichas S.A.", "73624062000148", "202204032"));
            empresas.Add(new Empresa(23, "20.16.10.16", "folig@acme.com.br", "184, chaussée de Tournai", "Martine Rancé", "Folies gourmandes", "54138384000132", "202204033"));
            empresas.Add(new Empresa(24, "0695-34 67 21", "folko@acme.com.br", "Åkergatan 24", "Maria Larsson", "Folk och fä HB", "70473546000145", "202204034"));
            empresas.Add(new Empresa(25, "089-0877310", "frank@acme.com.br", "Berliner Platz 43", "Peter Franken", "Frankenversand", "6167151000115", "202204035"));
            empresas.Add(new Empresa(26, "40.32.21.21", "franr@acme.com.br", "54, rue Royale", "Carine Schmitt", "France restauration", "55737857000180", "202204036"));
            empresas.Add(new Empresa(27, "011-4988260", "frans@acme.com.br", "Via Monte Bianco 34", "Paolo Accorti", "Franchi S.p.A.", "70760677000103", "202204037"));
            empresas.Add(new Empresa(28, "(1) 354-2534", "furib@acme.com.br", "Jardim das rosas n. 32", "Lino Rodriguez", "Furia Bacalhau e Frutos do Mar", "40268326000119", "202204038"));
            empresas.Add(new Empresa(29, "(93) 203 4560", "galed@acme.com.br", "Rambla de Cataluña, 23", "Eduardo Saavedra", "Galería del gastrónomo", "51014553000134", "202204039"));
            empresas.Add(new Empresa(30, "(95) 555 82 82", "godos@acme.com.br", "C/ Romero, 33", "José Pedro Freyre", "Godos Cocina Típica", "76416421000160", "202204040"));
            empresas.Add(new Empresa(31, "(11) 555-9482", "gourl@acme.com.br", "Av. Brasil, 442", "André Fonseca", "Gourmet Lanchonetes", "46721733000116", "202204041"));
            empresas.Add(new Empresa(32, "(503) 555-7555", "greal@acme.com.br", "2732 Baker Blvd.", "Howard Snyder", "Great Lakes Food Market", "11036656000180", "202204042"));
            empresas.Add(new Empresa(33, "(2) 283-2951", "grosr@acme.com.br", "5ª Ave. Los Palos Grandes", "Manuel Pereira", "GROSELLA-Restaurante", "67701617000105", "202204043"));
            empresas.Add(new Empresa(34, "(21) 555-0091", "hanar@acme.com.br", "Rua do Paço, 67", "Mario Pontes", "Hanari Carnes", "48453804000172", "202204044"));
            empresas.Add(new Empresa(35, "(5) 555-1340", "hilaa@acme.com.br", "Carrera 22 con Ave. Carlos Soublette #8-35", "Carlos Hernández", "HILARION-Abastos", "14083761000169", "202204045"));
            empresas.Add(new Empresa(36, "(503) 555-6874", "hungc@acme.com.br", "City Center Plaza 516 Main St.", "Yoshi Latimer", "Hungry Coyote Import Store", "61847418000123", "202204046"));
            empresas.Add(new Empresa(37, "2967 542", "hungo@acme.com.br", "8 Johnstown Road", "Patricia McKenna", "Hungry Owl All-Night Grocers", "86216774000170", "202204047"));
            empresas.Add(new Empresa(38, "(198) 555-8888", "islat@acme.com.br", "Garden House Crowther Way", "Helen Bennett", "Island Trading", "21854067000163", "202204048"));
            empresas.Add(new Empresa(39, "0555-09876", "koene@acme.com.br", "Maubelstr. 90", "Philip Cramer", "Königlich Essen", "4857210000151", "202204049"));
            empresas.Add(new Empresa(40, "30.59.84.10", "lacor@acme.com.br", "67, avenue de l'Europe", "Daniel Tonini", "La corne d'abondance", "2827107000133", "202204050"));
            empresas.Add(new Empresa(41, "61.77.61.10", "lamai@acme.com.br", "1 rue Alsace-Lorraine", "Annette Roulet", "La maison d'Asie", "63721337000108", "202204051"));
            empresas.Add(new Empresa(42, "(604) 555-3392", "laugb@acme.com.br", "1900 Oak St.", "Yoshi Tannamuri", "Laughing Bacchus Wine Cellars", "5842625000114", "202204052"));
            empresas.Add(new Empresa(43, "(509) 555-7969", "lazyk@acme.com.br", "12 Orchestra Terrace", "John Steel", "Lazy K Kountry Store", "50162788000100", "202204053"));
            empresas.Add(new Empresa(44, "069-0245984", "lehms@acme.com.br", "Magazinweg 7", "Renate Messner", "Lehmanns Marktstand", "31037815000179", "202204054"));
            empresas.Add(new Empresa(45, "(415) 555-5938", "letss@acme.com.br", "87 Polk St. Suite 5", "Jaime Yorres", "Let's Stop N Shop", "42013618000136", "202204055"));
            empresas.Add(new Empresa(46, "(9) 331-6954", "lilas@acme.com.br", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Carlos González", "LILA-Supermercado", "24044455000177", "202204056"));
            empresas.Add(new Empresa(47, "(8) 34-56-12", "linod@acme.com.br", "Ave. 5 de Mayo Porlamar", "Felipe Izquierdo", "LINO-Delicateses", "71728436000140", "202204057"));
            empresas.Add(new Empresa(48, "(503) 555-9573", "lonep@acme.com.br", "89 Chiaroscuro Rd.", "Fran Wilson", "Lonesome Pine Restaurant", "31005356000141", "202204058"));
            empresas.Add(new Empresa(49, "035-640230", "magaa@acme.com.br", "Via Ludovico il Moro 22", "Giovanni Rovelli", "Magazzini Alimentari Riuniti", "72355778000124", "202204059"));
            empresas.Add(new Empresa(50, "(02) 201 24 67", "maisd@acme.com.br", "Rue Joseph-Bens 532", "Catherine Dewey", "Maison Dewey", "3404346000143", "202204060"));
            empresas.Add(new Empresa(51, "(514) 555-8054", "merep@acme.com.br", "43 rue St. Laurent", "Jean Fresnière", "Mère Paillarde", "12347328000168", "202204061"));
            empresas.Add(new Empresa(52, "0342-023176", "morgk@acme.com.br", "Heerstr. 22", "Alexander Feuer", "Morgenstern Gesundkost", "14617070000106", "202204062"));
            empresas.Add(new Empresa(53, "(171) 555-7733", "norts@acme.com.br", "South House 300 Queensbridge", "Simon Crowther", "North/South", "77066124000102", "202204063"));
            empresas.Add(new Empresa(54, "(1) 135-5333", "ocean@acme.com.br", "Ing. Gustavo Moncada 8585 Piso 20-A", "Yvonne Moncada", "Océano Atlántico Ltda.", "87634373000100", "202204064"));
            empresas.Add(new Empresa(55, "(907) 555-7584", "oldwo@acme.com.br", "2743 Bering St.", "Rene Phillips", "Old World Delicatessen", "17604611000141", "202204065"));
            empresas.Add(new Empresa(56, "0221-0644327", "ottik@acme.com.br", "Mehrheimerstr. 369", "Henriette Pfalzheim", "Ottilies Käseladen", "83413270000151", "202204066"));
            empresas.Add(new Empresa(57, "(1) 42.34.22.66", "paris@acme.com.br", "265, boulevard Charonne", "Marie Bertrand", "Paris spécialités", "52765258000182", "202204067"));
            empresas.Add(new Empresa(58, "(5) 552-3745", "peric@acme.com.br", "Calle Dr. Jorge Cash 321", "Guillermo Fernández", "Pericles Comidas clásicas", "73681120000175", "202204068"));
            empresas.Add(new Empresa(59, "6562-9722", "picco@acme.com.br", "Geislweg 14", "Georg Pipps", "Piccolo und mehr", "88265537000124", "202204069"));
            empresas.Add(new Empresa(60, "(1) 356-5634", "prini@acme.com.br", "Estrada da saúde n. 58", "Isabel de Castro", "Princesa Isabel Vinhos", "20128047000142", "202204070"));
            empresas.Add(new Empresa(61, "(21) 555-4252", "quede@acme.com.br", "Rua da Panificadora, 12", "Bernardo Batista", "Que Delícia", "52278063000108", "202204071"));
            empresas.Add(new Empresa(62, "(11) 555-1189", "queen@acme.com.br", "Alameda dos Canàrios, 891", "Lúcia Carvalho", "Queen Cozinha", "7851148000189", "202204072"));
            empresas.Add(new Empresa(63, "0372-035188", "quick@acme.com.br", "Taucherstraße 10", "Horst Kloss", "QUICK-Stop", "83337120000106", "202204073"));
            empresas.Add(new Empresa(64, "(1) 123-5555", "ranch@acme.com.br", "Av. del Libertador 900", "Sergio Gutiérrez", "Rancho grande", "57440263000139", "202204074"));
            empresas.Add(new Empresa(65, "(505) 555-5939", "rattc@acme.com.br", "2817 Milton Dr.", "Paula Wilson", "Rattlesnake Canyon Grocery", "53443778000131", "202204075"));
            empresas.Add(new Empresa(66, "0522-556721", "reggc@acme.com.br", "Strada Provinciale 124", "Maurizio Moroni", "Reggiani Caseifici", "32367477000104", "202204076"));
            empresas.Add(new Empresa(67, "(21) 555-3412", "ricar@acme.com.br", "Av. Copacabana, 267", "Janete Limeira", "Ricardo Adocicados", "61806265000176", "202204077"));
            empresas.Add(new Empresa(68, "0897-034214", "ricsu@acme.com.br", "Grenzacherweg 237", "Michael Holz", "Richter Supermarkt", "42142664000135", "202204078"));
            empresas.Add(new Empresa(69, "(91) 745 6200", "romey@acme.com.br", "Gran Vía, 1", "Alejandra Camino", "Romero y tomillo", "70333656000101", "202204079"));
            empresas.Add(new Empresa(70, "07-98 92 35", "santg@acme.com.br", "Erling Skakkes gate 78", "Jonas Bergulfsen", "Santé Gourmet", "85453821000136", "202204080"));
            empresas.Add(new Empresa(71, "(208) 555-8097", "savea@acme.com.br", "187 Suffolk Ln.", "Jose Pavarotti", "Save-a-lot Markets", "13176645000121", "202204081"));
            empresas.Add(new Empresa(72, "(171) 555-1717", "seves@acme.com.br", "90 Wadhurst Rd.", "Hari Kumar", "Seven Seas Imports", "420231000154", "202204082"));
            empresas.Add(new Empresa(73, "31 12 34 56", "simob@acme.com.br", "Vinbæltet 34", "Jytte Petersen", "Simons bistro", "38740137000155", "202204083"));
            empresas.Add(new Empresa(74, "(1) 47.55.60.10", "specd@acme.com.br", "25, rue Lauriston", "Dominique Perrier", "Spécialités du monde", "66538186000145", "202204084"));
            empresas.Add(new Empresa(75, "(307) 555-4680", "splir@acme.com.br", "P.O. Box 555", "Art Braunschweiger", "Split Rail Beer & Ale", "15051418000103", "202204085"));
            empresas.Add(new Empresa(76, "(071) 23 67 22 20", "suprd@acme.com.br", "Boulevard Tirou, 255", "Pascale Cartrain", "Suprêmes délices", "41564252000120", "202204086"));
            empresas.Add(new Empresa(77, "(503) 555-3612", "thebi@acme.com.br", "89 Jefferson Way Suite 2", "Liz Nixon", "The Big Cheese", "41222641000178", "202204087"));
            empresas.Add(new Empresa(78, "(406) 555-5834", "thecr@acme.com.br", "55 Grizzly Peak Rd.", "Liu Wong", "The Cracker Box", "41602654000172", "202204088"));
            empresas.Add(new Empresa(79, "0251-031259", "tomsp@acme.com.br", "Luisenstr. 48", "Karin Josephs", "Toms Spezialitäten", "78178556000160", "202204089"));
            empresas.Add(new Empresa(80, "(5) 555-2933", "tortu@acme.com.br", "Avda. Azteca 123", "Miguel Angel Paolino", "Tortuga Restaurante", "2271460000180", "202204090"));
            empresas.Add(new Empresa(81, "(11) 555-2167", "tradh@acme.com.br", "Av. Inês de Castro, 414", "Anabela Domingues", "Tradição Hipermercados", "83658262000175", "202204091"));
            empresas.Add(new Empresa(82, "(206) 555-8257", "traih@acme.com.br", "722 DaVinci Blvd.", "Helvetius Nagy", "Trail's Head Gourmet Provisioners", "2172633000102", "202204092"));
            empresas.Add(new Empresa(83, "86 21 32 43", "vaffe@acme.com.br", "Smagsloget 45", "Palle Ibsen", "Vaffeljernet", "18575100000101", "202204093"));
            empresas.Add(new Empresa(84, "78.32.54.86", "victe@acme.com.br", "2, rue du Commerce", "Mary Saveley", "Victuailles en stock", "18487485000155", "202204094"));
            empresas.Add(new Empresa(85, "26.47.15.10", "vinet@acme.com.br", "59 rue de l'Abbaye", "Paul Henriot", "Vins et alcools Chevalier", "36604561000147", "202204095"));
            empresas.Add(new Empresa(86, "0711-020361", "wandk@acme.com.br", "Adenauerallee 900", "Rita Müller", "Die Wandernde Kuh", "4174132000190", "202204096"));
            empresas.Add(new Empresa(87, "981-443655", "warth@acme.com.br", "Torikatu 38", "Pirkko Koskitalo", "Wartian Herkku", "78550264000106", "202204097"));
            empresas.Add(new Empresa(88, "(14) 555-8122", "welli@acme.com.br", "Rua do Mercado, 12", "Paula Parente", "Wellington Importadora", "58142141000129", "202204098"));
            empresas.Add(new Empresa(89, "(206) 555-4112", "whitc@acme.com.br", "305 - 14th Ave. S. Suite 3B", "Karl Jablonski", "White Clover Markets", "81613521000116", "202204099"));
            empresas.Add(new Empresa(90, "90-224 8858", "wilmk@acme.com.br", "Keskuskatu 45", "Matti Karttunen", "Wilman Kala", "76784235000183", "202204100"));
            empresas.Add(new Empresa(91, "(26) 642-7012", "wolza@acme.com.br", "ul. Filtrowa 68", "Zbyszek Piestrzeniewicz", "Wolski  Zajazd", "6607774000161", "202204101"));
        }
    }
}
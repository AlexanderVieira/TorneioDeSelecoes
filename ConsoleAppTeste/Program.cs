using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //################### SORTEIO ####################
            var rnd = new Random();
            //var golsMarcados = rnd.Next(1, 6);
            //Console.WriteLine(golsMarcados);


            var selecoes = new List<String>
            {
                "Brasil",
                "Argentina",
                "Uruguai",
                "Colombia",
                "Espanha",
                "Alemanha",
                "Itália",
                "Inglaterra",
                "Holanda",
                "Suécia",
                "Portugal",
                "Croácia",
                "México",
                "Costa Rica",
                "Nigéria",
                "Marrocos"
            };

            foreach (var team in selecoes)
            {
                Console.WriteLine(team);
            }

            var chave1 = new List<String>();
            var chave2 = new List<String>();
            var chave3 = new List<String>();
            var chave4 = new List<String>();
            var chave5 = new List<String>();
            var chave6 = new List<String>();
            var chave7 = new List<String>();
            var chave8 = new List<String>();

            var oitavasFinal = new Dictionary<string, List<string>>();

            for (int i = 0; i < 2; i++)
            {
                if (chave1.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoes.Count);
                    chave1.Add(selecoes[selecaoEscolhida]);
                    selecoes.RemoveAt(selecaoEscolhida);

                }
                if (chave2.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoes.Count);
                    chave2.Add(selecoes[selecaoEscolhida]);
                    selecoes.RemoveAt(selecaoEscolhida);
                }
                if (chave3.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoes.Count);
                    chave3.Add(selecoes[selecaoEscolhida]);
                    selecoes.RemoveAt(selecaoEscolhida);
                }
                if (chave4.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoes.Count);
                    chave4.Add(selecoes[selecaoEscolhida]);
                    selecoes.RemoveAt(selecaoEscolhida);
                }
                if (chave5.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoes.Count);
                    chave5.Add(selecoes[selecaoEscolhida]);
                    selecoes.RemoveAt(selecaoEscolhida);
                }
                if (chave6.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoes.Count);
                    chave6.Add(selecoes[selecaoEscolhida]);
                    selecoes.RemoveAt(selecaoEscolhida);
                }
                if (chave7.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoes.Count);
                    chave7.Add(selecoes[selecaoEscolhida]);
                    selecoes.RemoveAt(selecaoEscolhida);
                }
                if (chave8.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoes.Count);
                    chave8.Add(selecoes[selecaoEscolhida]);
                    selecoes.RemoveAt(selecaoEscolhida);
                }

            }

            oitavasFinal.Add("Chave:1", chave1);
            oitavasFinal.Add("Chave:2", chave2);
            oitavasFinal.Add("Chave:3", chave3);
            oitavasFinal.Add("Chave:4", chave4);
            oitavasFinal.Add("Chave:5", chave5);
            oitavasFinal.Add("Chave:6", chave6);
            oitavasFinal.Add("Chave:7", chave7);
            oitavasFinal.Add("Chave:8", chave8);

            Console.WriteLine();

            for (var i = 0; i < oitavasFinal.Count; i++)
            {
                var par = oitavasFinal.ElementAt(i);
                Console.WriteLine();
                Console.WriteLine($"{par.Key}");
                Console.WriteLine($"{par.Value[0]} x {par.Value[1]}");

            }

            Console.WriteLine();
            var selecoesClassificadas = new List<String>();

            //###################### CHAVE 1 #########################
            var teamA = new Team();
            var teamB = new Team();

            while (true)
            {
                teamA.Nome = oitavasFinal["Chave:1"][0];
                teamA.Placar = rnd.Next(0, 6);

                teamB.Nome = oitavasFinal["Chave:1"][1];
                teamB.Placar = rnd.Next(0, 6);

                if (teamA.Placar > teamB.Placar)
                {
                    Console.WriteLine($"{teamA.Nome} {teamA.Placar} \n{teamB.Nome} {teamB.Placar}\n");
                    Console.WriteLine($"{teamA.Nome} Classificado!");
                    chave1.RemoveAt(1);
                    selecoesClassificadas.Add(teamA.Nome);
                    break;
                }
                else if (teamA.Placar < teamB.Placar)
                {
                    Console.WriteLine($"{teamA.Nome} {teamA.Placar} \n{teamB.Nome} {teamB.Placar}\n");
                    Console.WriteLine($"{teamB.Nome} Classificado!");
                    chave1.RemoveAt(0);
                    selecoesClassificadas.Add(teamB.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamA.Nome} {teamA.Placar} \n{teamB.Nome} {teamB.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 2 #########################
            var teamC = new Team();
            var teamD = new Team();

            while (true)
            {
                teamC.Nome = oitavasFinal["Chave:2"][0];
                teamC.Placar = rnd.Next(0, 6);

                teamD.Nome = oitavasFinal["Chave:2"][1];
                teamD.Placar = rnd.Next(0, 6);

                if (teamC.Placar > teamD.Placar)
                {
                    Console.WriteLine($"{teamC.Nome} {teamC.Placar} \n{teamD.Nome} {teamD.Placar}\n");
                    Console.WriteLine($"{teamC.Nome} Classificado!");
                    chave2.RemoveAt(1);
                    selecoesClassificadas.Add(teamC.Nome);
                    break;
                }
                else if (teamC.Placar < teamD.Placar)
                {
                    Console.WriteLine($"{teamC.Nome} {teamC.Placar} \n{teamD.Nome} {teamD.Placar}\n");
                    Console.WriteLine($"{teamD.Nome} Classificado!");
                    chave2.RemoveAt(0);
                    selecoesClassificadas.Add(teamD.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamC.Nome} {teamC.Placar} \n{teamD.Nome} {teamD.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 3 #########################
            var teamE = new Team();
            var teamF = new Team();

            while (true)
            {
                teamE.Nome = oitavasFinal["Chave:3"][0];
                teamE.Placar = rnd.Next(0, 6);

                teamF.Nome = oitavasFinal["Chave:3"][1];
                teamF.Placar = rnd.Next(0, 6);

                if (teamE.Placar > teamF.Placar)
                {
                    Console.WriteLine($"{teamE.Nome} {teamE.Placar} \n{teamF.Nome} {teamF.Placar}\n");
                    Console.WriteLine($"{teamE.Nome} Classificado!");
                    chave3.RemoveAt(1);
                    selecoesClassificadas.Add(teamE.Nome);
                    break;
                }
                else if (teamE.Placar < teamF.Placar)
                {
                    Console.WriteLine($"{teamE.Nome} {teamE.Placar} \n{teamF.Nome} {teamF.Placar}\n");
                    Console.WriteLine($"{teamF.Nome} Classificado!");
                    chave3.RemoveAt(0);
                    selecoesClassificadas.Add(teamF.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamE.Nome} {teamE.Placar} \n{teamF.Nome} {teamF.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 4 #########################
            var teamG = new Team();
            var teamH = new Team();

            while (true)
            {
                teamG.Nome = oitavasFinal["Chave:4"][0];
                teamG.Placar = rnd.Next(0, 6);

                teamH.Nome = oitavasFinal["Chave:4"][1];
                teamH.Placar = rnd.Next(0, 6);

                if (teamG.Placar > teamH.Placar)
                {
                    Console.WriteLine($"{teamG.Nome} {teamG.Placar} \n{teamH.Nome} {teamH.Placar}\n");
                    Console.WriteLine($"{teamG.Nome} Classificado!");
                    chave4.RemoveAt(1);
                    selecoesClassificadas.Add(teamG.Nome);
                    break;
                }
                else if (teamG.Placar < teamH.Placar)
                {
                    Console.WriteLine($"{teamG.Nome} {teamG.Placar} \n{teamH.Nome} {teamH.Placar}\n");
                    Console.WriteLine($"{teamH.Nome} Classificado!");
                    chave4.RemoveAt(0);
                    selecoesClassificadas.Add(teamH.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamG.Nome} {teamG.Placar} \n{teamH.Nome} {teamH.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogaçãot!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 5 #########################
            var teamI = new Team();
            var teamJ = new Team();

            while (true)
            {
                teamI.Nome = oitavasFinal["Chave:5"][0];
                teamI.Placar = rnd.Next(0, 6);

                teamJ.Nome = oitavasFinal["Chave:5"][1];
                teamJ.Placar = rnd.Next(0, 6);

                if (teamI.Placar > teamJ.Placar)
                {
                    Console.WriteLine($"{teamI.Nome} {teamI.Placar} \n{teamJ.Nome} {teamJ.Placar}\n");
                    Console.WriteLine($"{teamI.Nome} Classificado!");
                    chave5.RemoveAt(1);
                    selecoesClassificadas.Add(teamI.Nome);
                    break;
                }
                else if (teamI.Placar < teamJ.Placar)
                {
                    Console.WriteLine($"{teamI.Nome} {teamI.Placar} \n{teamJ.Nome} {teamJ.Placar}\n");
                    Console.WriteLine($"{teamJ.Nome} Classificado!");
                    chave5.RemoveAt(0);
                    selecoesClassificadas.Add(teamJ.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamI.Nome} {teamI.Placar} \n{teamJ.Nome} {teamJ.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 6 #########################
            var teamK = new Team();
            var teamL = new Team();

            while (true)
            {
                teamK.Nome = oitavasFinal["Chave:6"][0];
                teamK.Placar = rnd.Next(0, 6);

                teamL.Nome = oitavasFinal["Chave:6"][1];
                teamL.Placar = rnd.Next(0, 6);

                if (teamK.Placar > teamL.Placar)
                {
                    Console.WriteLine($"{teamK.Nome} {teamK.Placar} \n{teamL.Nome} {teamL.Placar}\n");
                    Console.WriteLine($"{teamK.Nome} Classificado!");
                    chave6.RemoveAt(1);
                    selecoesClassificadas.Add(teamK.Nome);
                    break;
                }
                else if (teamK.Placar < teamL.Placar)
                {
                    Console.WriteLine($"{teamK.Nome} {teamK.Placar} \n{teamL.Nome} {teamL.Placar}\n");
                    Console.WriteLine($"{teamL.Nome} Classificado!");
                    chave6.RemoveAt(0);
                    selecoesClassificadas.Add(teamL.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamK.Nome} {teamK.Placar} \n{teamL.Nome} {teamL.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 7 #########################
            var teamM = new Team();
            var teamN = new Team();

            while (true)
            {
                teamM.Nome = oitavasFinal["Chave:7"][0];
                teamM.Placar = rnd.Next(0, 6);

                teamN.Nome = oitavasFinal["Chave:7"][1];
                teamN.Placar = rnd.Next(0, 6);

                if (teamM.Placar > teamN.Placar)
                {
                    Console.WriteLine($"{teamM.Nome} {teamM.Placar} \n{teamN.Nome} {teamN.Placar}\n");
                    Console.WriteLine($"{teamM.Nome} Classificado!");
                    chave7.RemoveAt(1);
                    selecoesClassificadas.Add(teamM.Nome);
                    break;
                }
                else if (teamM.Placar < teamN.Placar)
                {
                    Console.WriteLine($"{teamM.Nome} {teamM.Placar} \n{teamN.Nome} {teamN.Placar}\n");
                    Console.WriteLine($"{teamN.Nome} Classificado!");
                    chave7.RemoveAt(0);
                    selecoesClassificadas.Add(teamN.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamM.Nome} {teamM.Placar} \n{teamN.Nome} {teamN.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 8 #########################
            var teamO = new Team();
            var teamP = new Team();

            while (true)
            {
                teamO.Nome = oitavasFinal["Chave:8"][0];
                teamO.Placar = rnd.Next(0, 6);

                teamP.Nome = oitavasFinal["Chave:8"][1];
                teamP.Placar = rnd.Next(0, 6);

                if (teamO.Placar > teamP.Placar)
                {
                    Console.WriteLine($"{teamO.Nome} {teamO.Placar} \n{teamP.Nome} {teamP.Placar}\n");
                    Console.WriteLine($"{teamO.Nome} Classificado!");
                    chave8.RemoveAt(1);
                    selecoesClassificadas.Add(teamO.Nome);
                    break;
                }
                else if (teamO.Placar < teamP.Placar)
                {
                    Console.WriteLine($"{teamO.Nome} {teamO.Placar} \n{teamP.Nome} {teamP.Placar}\n");
                    Console.WriteLine($"{teamP.Nome} Classificado!");
                    chave8.RemoveAt(0);
                    selecoesClassificadas.Add(teamP.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamO.Nome} {teamO.Placar} \n{teamP.Nome} {teamP.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Seleções classificadas para as Quartas de Finais: \n");

            foreach (var item in selecoesClassificadas)
            {
                Console.WriteLine(item);
            }

            var chave9 = new List<String>();
            var chave10 = new List<String>();
            var chave11 = new List<String>();
            var chave12 = new List<String>();

            var quartasDeFinal = new Dictionary<string, List<string>>();

            for (int i = 0; i < 2; i++)
            {
                if (chave9.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoesClassificadas.Count);
                    chave9.Add(selecoesClassificadas[selecaoEscolhida]);
                    selecoesClassificadas.RemoveAt(selecaoEscolhida);

                }
                if (chave10.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoesClassificadas.Count);
                    chave10.Add(selecoesClassificadas[selecaoEscolhida]);
                    selecoesClassificadas.RemoveAt(selecaoEscolhida);
                }
                if (chave11.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoesClassificadas.Count);
                    chave11.Add(selecoesClassificadas[selecaoEscolhida]);
                    selecoesClassificadas.RemoveAt(selecaoEscolhida);
                }
                if (chave12.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selecoesClassificadas.Count);
                    chave12.Add(selecoesClassificadas[selecaoEscolhida]);
                    selecoesClassificadas.RemoveAt(selecaoEscolhida);
                }
            }

            quartasDeFinal.Add("Chave:9", chave9);
            quartasDeFinal.Add("Chave:10", chave10);
            quartasDeFinal.Add("Chave:11", chave11);
            quartasDeFinal.Add("Chave:12", chave12);

            Console.WriteLine();

            for (var j = 0; j < quartasDeFinal.Count; j++)
            {
                var par = quartasDeFinal.ElementAt(j);
                Console.WriteLine();
                Console.WriteLine($"{par.Key}");
                Console.WriteLine($"{par.Value[0]} x {par.Value[1]}");
            }

            Console.WriteLine();
            var selClassForSemiFinal = new List<String>();

            //###################### CHAVE 9 #########################
            var team_A = new Team();
            var team_B = new Team();

            while (true)
            {
                team_A.Nome = quartasDeFinal["Chave:9"][0];
                team_A.Placar = rnd.Next(0, 6);

                team_B.Nome = quartasDeFinal["Chave:9"][1];
                team_B.Placar = rnd.Next(0, 6);

                if (team_A.Placar > teamB.Placar)
                {
                    Console.WriteLine($"{team_A.Nome} {team_A.Placar} \n{team_B.Nome} {team_B.Placar}\n");
                    Console.WriteLine($"{team_A.Nome} Classificado!");
                    chave9.RemoveAt(1);
                    selClassForSemiFinal.Add(team_A.Nome);
                    break;
                }
                else if (team_A.Placar < team_B.Placar)
                {
                    Console.WriteLine($"{team_A.Nome} {team_A.Placar} \n{team_B.Nome} {team_B.Placar}\n");
                    Console.WriteLine($"{team_B.Nome} Classificado!");
                    chave9.RemoveAt(0);
                    selClassForSemiFinal.Add(team_B.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{team_A.Nome} {team_A.Placar} \n{team_B.Nome} {team_B.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 10 #########################
            var team_C = new Team();
            var team_D = new Team();

            while (true)
            {
                team_C.Nome = quartasDeFinal["Chave:10"][0];
                team_C.Placar = rnd.Next(0, 6);

                team_D.Nome = quartasDeFinal["Chave:10"][1];
                team_D.Placar = rnd.Next(0, 6);

                if (team_C.Placar > team_D.Placar)
                {
                    Console.WriteLine($"{team_C.Nome} {team_C.Placar} \n{team_D.Nome} {team_D.Placar}\n");
                    Console.WriteLine($"{team_C.Nome} Classificado!");
                    chave10.RemoveAt(1);
                    selClassForSemiFinal.Add(team_C.Nome);
                    break;
                }
                else if (team_C.Placar < team_D.Placar)
                {
                    Console.WriteLine($"{team_C.Nome} {team_C.Placar} \n{team_D.Nome} {team_D.Placar}\n");
                    Console.WriteLine($"{team_D.Nome} Classificado!");
                    chave10.RemoveAt(0);
                    selClassForSemiFinal.Add(team_D.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{team_C.Nome} {team_C.Placar} \n{team_D.Nome} {team_D.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 11 #########################
            var team_E = new Team();
            var team_F = new Team();

            while (true)
            {
                team_E.Nome = quartasDeFinal["Chave:11"][0];
                team_E.Placar = rnd.Next(0, 6);

                team_F.Nome = quartasDeFinal["Chave:11"][1];
                team_F.Placar = rnd.Next(0, 6);

                if (team_E.Placar > team_F.Placar)
                {
                    Console.WriteLine($"{team_E.Nome} {team_E.Placar} \n{team_F.Nome} {team_F.Placar}\n");
                    Console.WriteLine($"{team_E.Nome} Classificado!");
                    chave11.RemoveAt(1);
                    selClassForSemiFinal.Add(team_E.Nome);
                    break;
                }
                else if (teamE.Placar < teamF.Placar)
                {
                    Console.WriteLine($"{team_E.Nome} {team_E.Placar} \n{team_F.Nome} {team_F.Placar}\n");
                    Console.WriteLine($"{team_F.Nome} Classificado!");
                    chave11.RemoveAt(0);
                    selClassForSemiFinal.Add(team_F.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{team_E.Nome} {team_E.Placar} \n{team_F.Nome} {team_F.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 12 #########################
            var team_G = new Team();
            var team_H = new Team();

            while (true)
            {
                team_G.Nome = quartasDeFinal["Chave:12"][0];
                team_G.Placar = rnd.Next(0, 6);

                team_H.Nome = quartasDeFinal["Chave:12"][1];
                team_H.Placar = rnd.Next(0, 6);

                if (team_G.Placar > team_H.Placar)
                {
                    Console.WriteLine($"{team_G.Nome} {team_G.Placar} \n{team_H.Nome} {team_H.Placar}\n");
                    Console.WriteLine($"{team_G.Nome} Classificado!");
                    chave12.RemoveAt(1);
                    selClassForSemiFinal.Add(team_G.Nome);
                    break;
                }
                else if (team_G.Placar < team_H.Placar)
                {
                    Console.WriteLine($"{team_G.Nome} {team_G.Placar} \n{team_H.Nome} {team_H.Placar}\n");
                    Console.WriteLine($"{team_H.Nome} Classificado!");
                    chave12.RemoveAt(0);
                    selClassForSemiFinal.Add(team_H.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{team_G.Nome} {team_G.Placar} \n{team_H.Nome} {team_H.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogaçãot!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Seleções classificadas para as Semi-Finais: \n");

            foreach (var item in selClassForSemiFinal)
            {
                Console.WriteLine(item);
            }

            var chave13 = new List<String>();
            var chave14 = new List<String>();

            var semiFinais = new Dictionary<string, List<string>>();

            for (int i = 0; i < 2; i++)
            {
                if (chave13.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selClassForSemiFinal.Count);
                    chave13.Add(selClassForSemiFinal[selecaoEscolhida]);
                    selClassForSemiFinal.RemoveAt(selecaoEscolhida);

                }
                if (chave14.Count < 2)
                {
                    var selecaoEscolhida = rnd.Next(0, selClassForSemiFinal.Count);
                    chave14.Add(selClassForSemiFinal[selecaoEscolhida]);
                    selClassForSemiFinal.RemoveAt(selecaoEscolhida);
                }
            }

            semiFinais.Add("Chave:13", chave13);
            semiFinais.Add("Chave:14", chave14);

            Console.WriteLine();

            for (var j = 0; j < semiFinais.Count; j++)
            {
                var par = semiFinais.ElementAt(j);
                Console.WriteLine();
                Console.WriteLine($"{par.Key}");
                Console.WriteLine($"{par.Value[0]} x {par.Value[1]}");
            }

            var selClassForFinal = new List<String>();

            //###################### CHAVE 13 #########################
            var _team_A = new Team();
            var _team_B = new Team();

            while (true)
            {
                _team_A.Nome = semiFinais["Chave:13"][0];
                _team_A.Placar = rnd.Next(0, 6);

                _team_B.Nome = semiFinais["Chave:13"][1];
                _team_B.Placar = rnd.Next(0, 6);

                if (_team_A.Placar > _team_B.Placar)
                {
                    Console.WriteLine($"{_team_A.Nome} {_team_A.Placar} \n{_team_B.Nome} {_team_B.Placar}\n");
                    Console.WriteLine($"{_team_A.Nome} Classificado!");
                    chave13.RemoveAt(1);
                    selClassForFinal.Add(_team_A.Nome);
                    break;
                }
                else if (_team_A.Placar < _team_B.Placar)
                {
                    Console.WriteLine($"{_team_A.Nome} {_team_A.Placar} \n{_team_B.Nome} {_team_B.Placar}\n");
                    Console.WriteLine($"{_team_B.Nome} Classificado!");
                    chave13.RemoveAt(0);
                    selClassForFinal.Add(_team_B.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{_team_A.Nome} {_team_A.Placar} \n{_team_B.Nome} {_team_B.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();

            //###################### CHAVE 14 #########################
            var _team_C = new Team();
            var _team_D = new Team();

            while (true)
            {
                _team_C.Nome = semiFinais["Chave:14"][0];
                _team_C.Placar = rnd.Next(0, 6);

                _team_D.Nome = semiFinais["Chave:14"][1];
                _team_D.Placar = rnd.Next(0, 6);

                if (_team_C.Placar > _team_D.Placar)
                {
                    Console.WriteLine($"{_team_C.Nome} {_team_C.Placar} \n{_team_D.Nome} {_team_D.Placar}\n");
                    Console.WriteLine($"{_team_C.Nome} Classificado!");
                    chave14.RemoveAt(1);
                    selClassForFinal.Add(_team_C.Nome);
                    break;
                }
                else if (_team_C.Placar < _team_D.Placar)
                {
                    Console.WriteLine($"{_team_C.Nome} {_team_C.Placar} \n{_team_D.Nome} {_team_D.Placar}\n");
                    Console.WriteLine($"{_team_D.Nome} Classificado!");
                    chave14.RemoveAt(0);
                    selClassForFinal.Add(_team_D.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{_team_C.Nome} {_team_C.Placar} \n{_team_D.Nome} {_team_D.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Seleções classificadas para final: \n");

            foreach (var item in selClassForFinal)
            {
                Console.WriteLine(item);
            }

            var finalDict = new Dictionary<string, List<string>>();

            finalDict.Add("Final", selClassForFinal);

            for (var j = 0; j < finalDict.Count; j++)
            {
                var par = finalDict.ElementAt(j);
                Console.WriteLine();
                Console.WriteLine($"{par.Key}");
                Console.WriteLine($"{par.Value[0]} x {par.Value[1]}");
            }

            //###################### FINAL #########################
            var teamX = new Team();
            var teamY = new Team();

            while (true)
            {
                teamX.Nome = finalDict["Final"][0];
                teamX.Placar = rnd.Next(0, 6);

                teamY.Nome = finalDict["Final"][1];
                teamY.Placar = rnd.Next(0, 6);

                if (teamX.Placar > teamY.Placar)
                {
                    Console.WriteLine($"{teamX.Nome} {teamX.Placar} \n{teamY.Nome} {teamY.Placar}\n");
                    Console.WriteLine($"{teamX.Nome} Campeão!!!");
                    selClassForFinal.RemoveAt(1);
                    selClassForFinal.Add(teamX.Nome);
                    break;
                }
                else if (teamX.Placar < teamY.Placar)
                {
                    Console.WriteLine($"{teamX.Nome} {teamX.Placar} \n{teamY.Nome} {teamY.Placar}\n");
                    Console.WriteLine($"{teamY.Nome} Campeão!!!");
                    selClassForFinal.RemoveAt(0);
                    selClassForFinal.Add(teamY.Nome);
                    break;
                }
                else
                {
                    Console.WriteLine($"{teamX.Nome} {teamX.Placar} \n{teamY.Nome} {teamY.Placar}\n");
                    Console.WriteLine($"Empate. Prorrogação!");
                    Console.ReadLine();
                }
            }

            Console.ReadLine();

        }
    }
}

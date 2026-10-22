int jpont = 0;
int gpont = 0;
do
{
    
    int kilepes = 0;
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("=== KŐ – PAPÍR – OLLÓ ===");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("[1] Új mérkőzés");
    Console.WriteLine("[2] Statisztika");
    Console.WriteLine("[3] Statisztika nullázása");
    Console.WriteLine("[K] Kilépés");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Válassz: ");
    Console.ResetColor();

    ConsoleKeyInfo billentyu = Console.ReadKey();
    Console.WriteLine();
    


    do
    {
        switch (billentyu.KeyChar)
        {
            case '1':
                if (kilepes == 1)
                {
                    Console.WriteLine("Kiléptél a mérkőzésből!");
                    break;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Új mérkőzés kezdődött!");
                Console.Write("Írj be egy betűt (K/P/O): ");
                Console.ResetColor();
                ConsoleKeyInfo jatekos = Console.ReadKey();

                Console.WriteLine();
                if (jatekos.KeyChar == 'K' || jatekos.KeyChar == 'k')
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("KŐ-t választottál!");
                    Console.ResetColor();
                }
                else if (jatekos.KeyChar == 'P' || jatekos.KeyChar == 'p')
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("PAPÍR-t választottál!");
                    Console.ResetColor();
                }
                else if (jatekos.KeyChar == 'O' || jatekos.KeyChar == 'o')
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("OLLÓ-t választottál!");
                    Console.ResetColor();
                }

                else if (jatekos.KeyChar == 'm' || jatekos.KeyChar == 'M')
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("KILÉPÉS...");
                    Console.ResetColor();
                    kilepes = 1;
                    Console.WriteLine();
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Ismeretlen billentyű!");
                    Console.ResetColor();
                    break;
                }

                int gep = Random.Shared.Next(3);
                if (gep == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("A gép KŐ-t választott!");
                    Console.ResetColor();
                }
                else if (gep == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("A gép PAPÍR-t választott!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("A gép OLLÓ-t választott!");
                    Console.ResetColor();
                }

                if ((jatekos.KeyChar == 'K' || jatekos.KeyChar == 'k') && gep == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nyertél!");
                    jpont++;
                    Console.ResetColor();
                }
                else if ((jatekos.KeyChar == 'P' || jatekos.KeyChar == 'p') && gep == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nyertél!");
                    jpont++;
                    Console.ResetColor();
                }
                else if ((jatekos.KeyChar == 'O' || jatekos.KeyChar == 'o') && gep == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nyertél!");
                    jpont++;
                    Console.ResetColor();
                }
                else if (jatekos.KeyChar == 'K' && gep == 0 || jatekos.KeyChar == 'k' && gep == 0 ||
                    jatekos.KeyChar == 'P' && gep == 1 || jatekos.KeyChar == 'p' && gep == 1 ||
                    jatekos.KeyChar == 'O' && gep == 2 || jatekos.KeyChar == 'o' && gep == 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Döntetlen!");
                    Console.ResetColor();
                }
                else if ((jatekos.KeyChar == 'K' || jatekos.KeyChar == 'k') && gep == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vesztettél!");
                    gpont++;
                    Console.ResetColor();
                }
                else if ((jatekos.KeyChar == 'P' || jatekos.KeyChar == 'p') && gep == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vesztettél!");
                    gpont++;
                    Console.ResetColor();
                }
                else if ((jatekos.KeyChar == 'O' || jatekos.KeyChar == 'o') && gep == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vesztettél!");
                    gpont++;
                    Console.ResetColor();
                }
                


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valami gubanc történt, próbáld újra!");
                    Console.ResetColor();
                }

                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"A játékos pontszáma: {jpont}");
                Console.WriteLine($"A gép pontszáma: {gpont}");

                int kerdesism = 0;
                do
                {
                    if (jpont >= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Gratulálok, nyertél!");
                        Console.ResetColor();
                        jpont = 0;
                        gpont = 0;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Szeretnél új játékot kezdeni? (I/N): ");
                        Console.ResetColor();
                        ConsoleKeyInfo ujjatek = Console.ReadKey();
                        if (ujjatek.KeyChar == 'I' || ujjatek.KeyChar == 'i')
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Új játék kezdése...!");
                            Console.ResetColor();
                            kerdesism = 1;
                        }
                        else if (ujjatek.KeyChar == 'N' || ujjatek.KeyChar == 'n')
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Kiléptél a játékból!");
                            Console.ResetColor();
                            kilepes = 1;
                            kerdesism = 1;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine("Ismeretlen billentyű!");
                            Console.ResetColor();
                        }
                    }
                    else if (gpont >= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Sajnálom, vesztettél!");
                        Console.ResetColor();
                        jpont = 0;
                        gpont = 0;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Szeretnél új játékot kezdeni? (I/N): ");
                        Console.ResetColor();
                        ConsoleKeyInfo ujjatek = Console.ReadKey();
                        if (ujjatek.KeyChar == 'I' || ujjatek.KeyChar == 'i')
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Új játék kezdése...!");
                            Console.ResetColor();
                            kerdesism = 1;
                        }
                        else if (ujjatek.KeyChar == 'N' || ujjatek.KeyChar == 'n')
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Kiléptél a játékból!");
                            Console.ResetColor();
                            Console.WriteLine();
                            kilepes = 1;
                            kerdesism = 1;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine("Ismeretlen billentyű!");
                            Console.ResetColor();
                        }
                    }
                } while (kerdesism == 0);


                break;

            case '2':

                break;

            case '3':

                break;

            case 'k':
                kilepes = 1;

                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ismeretlen billentyű!");
                Console.ResetColor();
                break;
        }
    } while (kilepes == 0);
} while (true);
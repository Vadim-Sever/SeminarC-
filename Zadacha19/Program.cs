// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
        
        
        string a = Console.ReadLine();

        int dlina = a.Length;
        int seredina = dlina / 2;
        // Console.WriteLine(dlina);
        // Console.WriteLine(seredina);
        int result = 1;
        int j = dlina - 1;
        for (int i = 0; i < dlina; i++) {
                if (j > seredina) {
                    if (a[i] != a[j]) {
                        result = -1;
                        break;
                    }
                } else {
                    break;
                }
                j--;
            }

        if (result == -1)
        {
            Console.WriteLine("нет");
        }
        if (result == 1)
        {
            Console.WriteLine("да");
        }
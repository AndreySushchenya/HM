
            Double x1=0;
            Double x2=0;
            Double y1=0;
            Double y2=0;
            Double rasst;
            Console.Write("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
    
                rasst = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)); // Math.Sqrt - высчитывает квадратный корень выражения в скобках
                Console.WriteLine("rasst:" + rasst);                      // Math.Pow  - возводит первое число в скобке в степень (второе число в скобке)
                                                                          // MAth.Pow(4,3) - 4 возведет в 3 степень
                                                                          

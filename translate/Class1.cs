namespace Translate;

public class Edf
{
    // def hiper_periodo(processos, qnt):
    //   # Hiper Periodo é o maior periodo dentre todos os processos
    //   temp = 0
    //   for i in range(qnt):
    //       if processos[i][3] > temp:
    //           temp = processos[i][3]
    // return temp

    public static int HiperPeriod(int[,] processos, int qnt)
    {
        int temp = 0;
        for (int i = 0; i < qnt; i++)
        {
            if (processos[i, 3] > temp)
            {
                temp = processos[i, 3];
            }
        }
        return temp;
    }

    // def escolher_menor_deadline(processos, qnt, deadlines):
    // menor_deadline = 10000
    // escolhido = -1
    // for i in range(qnt):
    //     if deadlines[i] < menor_deadline:
    //         menor_deadline = deadlines[i]
    //         escolhido = i
    // return escolhido

    public static int MenorDeadline(int qnt, int[] deadlines)
    {
        int menor_deadline = 10000;
        int escolhido = -1;
        for (int i = 0; i < qnt; i++)
        {
            if (deadlines[i] < menor_deadline)
            {
                menor_deadline = deadlines[i];
                escolhido = i;
            }
        }
        return escolhido;
    }
}

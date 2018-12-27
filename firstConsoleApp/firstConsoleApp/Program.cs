using System;

public class LearnCsharp
{

    public static int? ticketsOnSale = null;

    public static int Main()
    {
        return CalculateTickets();
    }

    public static int CalculateTickets() {
        int availableTickets;//= ticketsOnSale ?? 0;

        if(ticketsOnSale == null || ticketsOnSale < 0) {
            availableTickets = 0;
        } else {
            availableTickets = ticketsOnSale.Value;// or (int)ticketsOnSale
        }

        return availableTickets;
    }

    public static int NullChecks() {
        int availableTickets = ticketsOnSale ?? 0;

        return availableTickets;
    }
}


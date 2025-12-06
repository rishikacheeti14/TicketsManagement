import { Component, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TicketService } from '../../services/ticket-service';
import { Ticket } from '../../models/ticket.model';

@Component({
  selector: 'app-tickets',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './tickets.html',
  styleUrls: ['./tickets.css']
})
export class Tickets {

  tickets = signal<Ticket[]>([]);

  constructor(private ticketService: TicketService) {
    this.loadTickets();
  }

  loadTickets() {
    this.ticketService.getTickets().subscribe({
      next: (data) => {
        this.tickets.set(data);
      },
      error: (err) => {
        console.error('Failed to load tickets', err);
      }
    });
  }
}

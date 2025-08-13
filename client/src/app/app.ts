import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  private http = inject(HttpClient);
  protected title = 'Dating app';

  ngOnInit(): void {
    // el Get devuelve un observable (herramienta para gestionar flujos de datos asíncronos)
    // por lo que hay que suscribirse
    this.http.get('https://localhost:5001/api/members').subscribe({
      next: Response => console.log('next: ', Response),
      error: error => console.error('There was an error!', error),
      complete: () => console.log('Request completed')
    })
  }
}

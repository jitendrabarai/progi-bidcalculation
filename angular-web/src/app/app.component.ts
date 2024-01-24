// It's used to serves as the root component, providing the main structure and behavior for the entire application.
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Progi - Bid Calculator';
}

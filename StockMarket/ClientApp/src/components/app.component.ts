import { Component } from '@angular/core';

export interface Option {
  label: string;
  selected: boolean;
  value: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'app';
}

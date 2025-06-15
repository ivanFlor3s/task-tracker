import { Component, input } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-menu-item',
  imports: [RouterModule],
  templateUrl: './menu-item.component.html',
  styleUrl: './menu-item.component.css',
})
export class MenuItemComponent {
  icon = input.required<string>();
  label = input.required<string>();
  route = input.required<string>();
  isActive = input<boolean>(false);
}

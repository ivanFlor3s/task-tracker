import { CommonModule } from '@angular/common';
import { Component, input } from '@angular/core';
import { MenuItemComponent } from '../menu-item/menu-item.component';
import { MenuItem } from '../../../features/dashboard/models/menu-item';

@Component({
  selector: 'app-side-bar',
  imports: [CommonModule, MenuItemComponent],
  templateUrl: './side-bar.component.html',
  styleUrl: './side-bar.component.css',
})
export class SideBarComponent {
  menuItems = input.required<MenuItem[]>();
}

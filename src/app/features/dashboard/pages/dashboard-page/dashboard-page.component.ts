import { Component } from '@angular/core';
import { SideBarComponent } from '../../../../shared/components/side-bar/side-bar.component';
import { MenuItem } from '../../models/menu-item';

@Component({
  selector: 'app-dashboard-page',
  imports: [SideBarComponent],
  templateUrl: './dashboard-page.component.html',
  styleUrl: './dashboard-page.component.css',
})
export class DashboardPageComponent {
  menu: MenuItem[] = [
    { icon: 'home', label: 'Home', route: '/dashboard' },
    { icon: 'tasks', label: 'Tasks', route: '/tasks' },
    { icon: 'reports', label: 'Reports', route: '/calendar' },
    { icon: 'settings', label: 'Settings', route: '/settings' },
  ];
}

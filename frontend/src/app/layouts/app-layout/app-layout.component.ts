import { Component } from '@angular/core';
import { MenuItem } from '../../features/dashboard/models/menu-item';
import { SideBarComponent } from '../../shared/components/side-bar/side-bar.component';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-app-layout',
  imports: [SideBarComponent, RouterOutlet],
  templateUrl: './app-layout.component.html',
  styleUrl: './app-layout.component.css',
})
export class AppLayoutComponent {
  menu: MenuItem[] = [
    { icon: 'home', label: 'Home', route: '/dashboard' },
    { icon: 'tasks', label: 'Tasks', route: '/tasks' },
    { icon: 'reports', label: 'Reports', route: '/calendar' },
    { icon: 'settings', label: 'Settings', route: '/settings' },
  ];
}

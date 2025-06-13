import { Component } from '@angular/core';
import { SideBarComponent } from '../../../../shared/components/side-bar/side-bar.component';

@Component({
  selector: 'app-dashboard-page',
  imports: [SideBarComponent],
  templateUrl: './dashboard-page.component.html',
  styleUrl: './dashboard-page.component.css',
})
export class DashboardPageComponent {}

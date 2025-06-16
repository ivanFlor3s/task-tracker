import { Component } from '@angular/core';
import { ItemTaskCardComponent } from '../../components/item-task-card/item-task-card.component';

@Component({
  selector: 'app-tasks-page',
  imports: [ItemTaskCardComponent],
  templateUrl: './tasks-page.component.html',
  styleUrl: './tasks-page.component.css',
})
export class TasksPageComponent {}

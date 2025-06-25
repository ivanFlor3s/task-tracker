import { Component } from '@angular/core';
import { ItemTaskCardComponent } from '../../components/item-task-card/item-task-card.component';
import { CreateTaskComponent } from '../../components/create-task/create-task.component';

@Component({
  selector: 'app-tasks-page',
  imports: [ItemTaskCardComponent, CreateTaskComponent],
  templateUrl: './tasks-page.component.html',
  styleUrl: './tasks-page.component.css',
})
export class TasksPageComponent {}

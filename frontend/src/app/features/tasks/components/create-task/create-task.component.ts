import { Component } from '@angular/core';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatChipsModule } from '@angular/material/chips';

@Component({
  selector: 'app-create-task',
  imports: [MatFormFieldModule, MatInputModule, MatSelectModule, MatChipsModule],
  templateUrl: './create-task.component.html',
  styleUrl: './create-task.component.css',
})
export class CreateTaskComponent {
  readonly tags: string[] = ['Planeado', 'Contingencia', 'Corte'];
}

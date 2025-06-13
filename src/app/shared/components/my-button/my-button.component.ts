import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-my-button',
  imports: [CommonModule],
  templateUrl: './my-button.component.html',
  styleUrl: './my-button.component.css',
})
export class MyButtonComponent {
  @Input() label = 'Botón';
  @Input() disabled = false;
  @Input() color: 'primary' | 'secondary' | 'danger' = 'primary';

  @Output() clicked = new EventEmitter<void>();

  get classes(): string {
    switch (this.color) {
      case 'secondary':
        return 'bg-gray-500 hover:bg-gray-600';
      case 'danger':
        return 'bg-red-500 hover:bg-red-600';
      default:
        return 'bg-blue-500 hover:bg-blue-600';
    }
  }

  handleClick(): void {
    if (!this.disabled) {
      this.clicked.emit();
    }
  }
}

import { ChangeDetectionStrategy, Component, input } from '@angular/core';
import { TAG_COLOR_CLASSES } from '../../assets/tag-colors';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-tag',
  imports: [CommonModule],
  templateUrl: './tag.component.html',
  styleUrl: './tag.component.css',
  host: {
    class: 'inline-block',
  },
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class TagComponent {
  colors = TAG_COLOR_CLASSES;
  color = input.required<'green' | 'blue' | 'red' | 'yellow' | 'gray'>();
  label = input.required<string>();
}

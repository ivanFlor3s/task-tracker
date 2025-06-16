import { ChangeDetectionStrategy, Component, input, signal } from '@angular/core';
import { TimerComponent } from '../../../../shared/components/timer/timer.component';
import { interval } from 'rxjs';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';

@Component({
  selector: 'app-item-task-card',
  imports: [TimerComponent],
  templateUrl: './item-task-card.component.html',
  styleUrl: './item-task-card.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ItemTaskCardComponent {
  label = input<string>('Task Name');
  seconds = signal(0);

  constructor() {
    this.startTimer();
  }

  startTimer() {
    interval(100)
      .pipe(takeUntilDestroyed())
      .subscribe(() => {
        this.seconds.update((s) => s + 1);
      });
  }
}

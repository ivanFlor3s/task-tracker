import { DecimalPipe } from '@angular/common';
import { Component, computed, input } from '@angular/core';

@Component({
  selector: 'app-timer',
  imports: [DecimalPipe],
  templateUrl: './timer.component.html',
  styleUrl: './timer.component.css',
})
export class TimerComponent {
  seconds = input<number>(0);

  minutes = computed(() => Math.floor(this.seconds() / 60));
  secondsToShow = computed(() => this.seconds() % 60);
}

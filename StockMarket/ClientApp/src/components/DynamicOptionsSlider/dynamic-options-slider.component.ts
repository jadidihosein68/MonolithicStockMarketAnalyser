import { Component } from '@angular/core';
import { Options } from 'ng5-slider';

@Component({
  selector: 'range-slider',
  templateUrl: './dynamic-options-slider.html'
})
export class RangeSliderComponent {
  minValue: number = 20;
  maxValue: number = 80;
  options: Options = {
    floor: 0,
    ceil: 100,
    step: 5
  };
}
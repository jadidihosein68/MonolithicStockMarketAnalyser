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
    floor: 2018/1/1,
    ceil: 2019/1/1,
    step: 1
  };
}
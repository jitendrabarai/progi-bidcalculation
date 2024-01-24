import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'decimalFormat'
})
export class DecimalFormatPipe implements PipeTransform {
  transform(value: number): string {
    // Check if the value is a decimal (has a decimal point)
    if (value % 1 !== 0) {
      // Display two decimal places for decimals
      return value.toFixed(2);
    } else {
      // Display integers as they are
      return value.toString();
    }
  }
}

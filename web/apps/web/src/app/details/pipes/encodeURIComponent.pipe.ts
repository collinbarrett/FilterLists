import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'encodeURIComponent' })
export class EncodeURIComponentPipe implements PipeTransform {
  transform(value: string) {
    return encodeURIComponent(value);
  }
}

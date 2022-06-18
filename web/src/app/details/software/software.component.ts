import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { Software } from '../../services/filter-list-details';

@Component({
  selector: 'app-software',
  templateUrl: './software.component.html',
  styleUrls: ['./software.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class SoftwareComponent {
  @Input() software: Software[] | undefined;
}

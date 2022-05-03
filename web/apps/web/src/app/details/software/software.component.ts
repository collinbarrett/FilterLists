import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { Software } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-software',
  templateUrl: './software.component.html',
  styleUrls: ['./software.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class SoftwareComponent {
  @Input() software: Software[] | undefined;
}

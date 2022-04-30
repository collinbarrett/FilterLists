import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { License } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-license-details',
  templateUrl: './license-details.component.html',
  styleUrls: ['./license-details.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LicenseDetailsComponent {
  @Input() license: License | undefined;
}

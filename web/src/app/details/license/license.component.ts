import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { License } from '../../services/filter-list-details';

@Component({
  selector: 'app-license',
  templateUrl: './license.component.html',
  styleUrls: ['./license.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LicenseComponent {
  @Input() license: License | undefined;
}

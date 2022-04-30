import { Component, Input } from '@angular/core';

import { License } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-license-details',
  templateUrl: './license-details.component.html',
  styleUrls: ['./license-details.component.scss'],
})
export class LicenseDetailsComponent {
  @Input() license: License | undefined;
}

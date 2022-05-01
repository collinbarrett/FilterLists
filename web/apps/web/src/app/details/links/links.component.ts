import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';

import { FilterListDetails } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-links',
  templateUrl: './links.component.html',
  styleUrls: ['./links.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LinksComponent {
  @Input() listDetails: FilterListDetails | undefined;

  constructor(private readonly sanitizer: DomSanitizer) {}

  getSubscribeUrl(index: number) {
    return this.sanitizer.bypassSecurityTrustUrl(
      'abp:subscribe?location=' +
        encodeURIComponent(this.listDetails?.viewUrls[index]?.url ?? '') +
        '&title=' +
        encodeURIComponent(this.listDetails?.name ?? '')
    );
  }
}

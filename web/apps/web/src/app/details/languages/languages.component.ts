import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { Language } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-languages',
  templateUrl: './languages.component.html',
  styleUrls: ['./languages.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LanguagesComponent {
  @Input() languages: Language[] | undefined;
}

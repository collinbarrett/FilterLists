import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { Syntax } from '../../services/filter-list-details';

@Component({
  selector: 'app-syntaxes',
  templateUrl: './syntaxes.component.html',
  styleUrls: ['./syntaxes.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class SyntaxesComponent {
  @Input() syntaxes: Syntax[] | undefined;
}

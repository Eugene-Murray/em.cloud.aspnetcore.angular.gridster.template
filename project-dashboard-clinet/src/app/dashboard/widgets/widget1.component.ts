import {
    ChangeDetectionStrategy,
    Component,
    OnInit,
    ViewEncapsulation
  } from '@angular/core';
  
  @Component({
    selector: 'widget1',
    templateUrl: './widget1.component.html',
    styleUrls: ['./widget1.component.scss'],
    // changeDetection: ChangeDetectionStrategy.OnPush,
    // encapsulation: ViewEncapsulation.None
  })
  export class Widget1Component implements OnInit {
  
    public name: string = "widget 1";

    constructor() { }

    ngOnInit() { }

  }
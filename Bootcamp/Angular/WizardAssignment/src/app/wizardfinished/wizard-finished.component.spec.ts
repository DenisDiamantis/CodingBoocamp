import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WizardFinishedComponent } from './wizardfinished.component';

describe('WizardFinishedComponent', () => {
  let component: WizardFinishedComponent;
  let fixture: ComponentFixture<WizardFinishedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WizardFinishedComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WizardFinishedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

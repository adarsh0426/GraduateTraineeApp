import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddGraduateTraineeComponent } from './add-graduate-trainee.component';

describe('AddGraduateTraineeComponent', () => {
  let component: AddGraduateTraineeComponent;
  let fixture: ComponentFixture<AddGraduateTraineeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddGraduateTraineeComponent]
    });
    fixture = TestBed.createComponent(AddGraduateTraineeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

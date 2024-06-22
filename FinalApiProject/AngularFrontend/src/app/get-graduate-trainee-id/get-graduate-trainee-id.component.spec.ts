import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetGraduateTraineeIdComponent } from './get-graduate-trainee-id.component';

describe('GetGraduateTraineeIdComponent', () => {
  let component: GetGraduateTraineeIdComponent;
  let fixture: ComponentFixture<GetGraduateTraineeIdComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GetGraduateTraineeIdComponent]
    });
    fixture = TestBed.createComponent(GetGraduateTraineeIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

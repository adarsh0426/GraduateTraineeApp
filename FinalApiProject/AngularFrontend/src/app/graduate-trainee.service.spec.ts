import { TestBed } from '@angular/core/testing';

import { GraduateTraineeService } from './graduate-trainee.service';

describe('GraduateTraineeService', () => {
  let service: GraduateTraineeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GraduateTraineeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

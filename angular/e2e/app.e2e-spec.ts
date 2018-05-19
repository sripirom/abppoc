import { BathawkTemplatePage } from './app.po';

describe('Bathawk App', function() {
  let page: BathawkTemplatePage;

  beforeEach(() => {
    page = new BathawkTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

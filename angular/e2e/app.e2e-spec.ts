import { SaaSTemplatePage } from './app.po';

describe('SaaS App', function() {
  let page: SaaSTemplatePage;

  beforeEach(() => {
    page = new SaaSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

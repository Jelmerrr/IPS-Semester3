import renderer from 'react-test-renderer';
import Profile from '../Pages/Profile';
import React from "react";

it('renders correctly', () => {
    const tree = renderer
        .create(<Profile page="http://www.test.com">Test</Profile>)
        .toJSON();
    expect(tree).toMatchSnapshot();
});